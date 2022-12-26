using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luan_Chat
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
            listSocket = new List<Socket>();
            chenEmoji();
           // chenIcon();
        }
        Socket socketServer, socketClient;
        List<Socket> listSocket;  
        IPEndPoint endpoint;
        IPAddress ip;
        int port = 3110;
        bool multiple = false;
        public static String duongDan()
        {
            string duongDan = Environment.CurrentDirectory.ToString(); // lấy đường dẫn thư mục
            var url = Directory.GetParent(Directory.GetParent(duongDan).ToString()); // lấy thư mục cha

            return url.ToString();

        }

       

        private void chenEmoji()
        {
            string path = duongDan() + @"\Emoij"; // lấy đường dẫn

            string[] files = Directory.GetFiles(path); // lấy tên file là ảnh

            foreach (String f in files)
            {
                Image img = Image.FromFile(f);  // từ cái file đó chuyển qua định dạng ảnh
                imageList2.Images.Add(img); // bỏ vào img list
            }
            this.listIcons.View = View.LargeIcon;
            this.imageList2.ImageSize = new Size(32, 32);

            this.listIcons.LargeImageList = this.imageList2;
            for (int i = 0; i < this.imageList2.Images.Count; i++)
            {
                this.listIcons.Items.Add(" ", i);
            }

        }
        private void newSocket()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            ip = IPAddress.Any;
            endpoint = new IPEndPoint(ip, port);
            socketServer.Bind(endpoint);

            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    socketServer.Listen(10);
                    Socket client = socketServer.Accept();
                    listSocket.Add(client);
                    sendMuti.Items.Add(client.LocalEndPoint.ToString());
                    //strings.Add(client.LocalEndPoint.ToString());
                    chenItemMess();
                    Thread receive = new Thread(Receive);
                    //receive.IsBackground = true;
                    receive.SetApartmentState(ApartmentState.STA);
                    receive.Start(client);
                    //string list = "lisClients:";
                    if (listSocket.Count > 1)
                    {
                        string list = "listClients:";
                        foreach (Socket socket in listSocket)
                        {
                            list = "listClients:";
                            foreach(Socket s in listSocket)
                            {
                                if (s != socket)
                                {
                                    list += s.LocalEndPoint.ToString() + ",";
                                }
                            }
                            socket.Send(mySerialize(list));

                        }
                    }
                    
                }
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void chenItemMess()
        {
            listMess.Items.Clear();
            foreach(Socket socket in listSocket)
            {
                listMess.Items.Add(socket.LocalEndPoint.ToString());
            }
            
        }
        
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            using (ms)
            {
                //saving image on current project directory
                Image img = Image.FromStream(ms);
                return img;
                //img.Save(Environment.CurrentDirectory + "file.eps");
            }
        }
        private bool IsValidImage(byte[] bytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                    Image.FromStream(ms);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }
        private void Receive(Object obj)
        {
            Socket socket = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //byte[] data = new byte[1024 * 5000]; 
                    if (socket.Receive(buffer) != 0)
                    {   
                        if (IsValidImage(buffer))
                        {
                            Image image = (Image)byteArrayToImage(buffer);
                            Clipboard.SetImage(image);
                            mes.AppendText((mes.Text == "" ? "" : "\n\n") + socket.LocalEndPoint + "\t" + DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy") + "\n");
                            mes.ReadOnly = false;
                            mes.Select(mes.Text.ToString().Length, 0);
                            mes.Paste();
                            mes.AppendText("\n");
                            mes.ReadOnly = true;
                            //MessageBox.Show("gởi ảnh thành công!");
                        }
                        else
                        {
                            mes.AppendText( (mes.Text == "" ? "" : "\n\n") + socket.LocalEndPoint + "\t" + DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy") + "\n\t" + myDeserialize(buffer));
                        }
                    }
                }

            }
            catch
            {
                sendMuti.Items.Remove(socket.LocalEndPoint.ToString());
                //strings.Remove(socket.LocalEndPoint.ToString());
                socket.Close();
                listSocket.Remove(socket);
                chenItemMess();
                if (listSocket.Count > 0)
                {
                    string list = "listClients:";
                    foreach (Socket sk in listSocket)
                    {
                        list = "listClients:";
                        foreach (Socket s in listSocket)
                        {
                            if (s != sk)
                            {
                                list += s.LocalEndPoint.ToString() + ",";
                            }
                        }
                        sk.Send(mySerialize(list));

                    }
                }
            }

        }
        
        private async void FrmServer_Load(object sender, EventArgs e)
        {
            newSocket();
            /*ReceiveMesage();
            *//*Task task = Task.Run(() => run());*//*
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    if (threadReceive.ThreadState == ThreadState.Stopped)
                    {
                        ReceiveMesage();
                    }
                }
            });
            thread.Start();*/
        }
        
        
        private void mySent()
        {


            if (multiple)
            {
                string a = "";
                foreach (var item in sendMuti.CheckedItems)
                {
                    foreach(Socket socket in listSocket)
                    {
                        if(socket.LocalEndPoint.ToString()== item.ToString())
                        {
                            socketSend(socket);
                            continue;
                        }
                    }
                }
                
            }
            else
            {
                if (socketClient != null)
                    socketSend(socketClient);
                else socketSend(listSocket[0]);
            }
            path = "";
            txtSent.Text = "";
        }

        private void socketSend(Socket socket)
        {
            if (path != "")
            {
                Image image = Image.FromFile(path);
                byte[] data = new byte[1024 * 10000];
                data = ImageToByteArray(image);
                socket.Send(data);
                mes.AppendText((mes.Text == "" ? "" : "\n\n") + "Tôi" + "\t" + DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy") + "\n");
                mes.AppendText("\n");
                mes.ReadOnly = false;
                //message.Select(message.Text.ToString().Length, 0);
                mes.Paste();
                mes.ReadOnly = true;
                
               
            }
            else
            {
                //mySent();
                socket.Send(mySerialize(txtSent.Text.ToString()));
                mes.AppendText((mes.Text == "" ? "" : "\n\n") + "Tôi" + "\t" + DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy") + "\n\t" + txtSent.Text);
            }
        }
        private void btnSent_Click(object sender, EventArgs e)
        {
            mySent();
            
        }
        
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                DialogResult dlr = MessageBox.Show("Bạn có muốn gởi file này đi không?",
     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dlr== DialogResult.Yes)
                {
                    foreach (Socket socket in listSocket)
                    {
                       sendFile(path, socket);
                    }
                }
            }*/
            //listAdd.Visible = true;
            if (pnAdd.Visible == true)
            {
                pnAdd.Visible = false;
            }
            else pnAdd.Visible = true;
        }

        private void sendFile(string filename, Socket socket)
        {
            string path = "";
            filename = filename.Replace("\\", "/");
            while (filename.IndexOf("/") > -1)
            {
                path+=filename.Substring(0, filename.IndexOf("/")+1);
                filename = filename.Substring(filename.IndexOf("/")+1);
            }
            byte[] fnamebyte = Encoding.ASCII.GetBytes(filename);

            byte[] fileData = File.ReadAllBytes(path + filename);
            byte[] sentData = new byte[4 + filename.Length + fileData.Length];

            byte[] fNameLen = BitConverter.GetBytes(fnamebyte.Length);
            fNameLen.CopyTo(sentData, 0);
            fnamebyte.CopyTo(sentData, 4 + fnamebyte.Length);
            socket.Send(sentData);
        }

        private string myDeserialize(byte[] bytes)
        {
            return Encoding.Unicode.GetString(bytes, 0, bytes.Length);
        }

        private void tsRemove_Click(object sender, EventArgs e)
        {
        }
        private string path = "";
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "Image|*.bmp;*.jpg;*.gif;*.png;*.tif";
            image.ShowDialog();
            path = image.FileName;
            if (path != "")
            {
                Clipboard.SetImage(Image.FromFile(path));
                txtSent.Paste();
                pnAdd.Visible = false;
            }
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            if (listIcons.Visible == true)
            {
                listIcons.Visible = false;

            }
            else listIcons.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  _ = sendMuti.Visible == false ? sendMuti.Visible = true : sendMuti.Visible = false;
            if (sendMuti.Visible)
            {
                sendMuti.Visible = false;
                multiple = false;
            }
            else
            {
                multiple = true;
                sendMuti.Visible = true;
            }
        }

        
        private void sendMuti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void listMess_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int  i= 0; i < listMess.Items.Count; i++)
            {
                if (listMess.Items[i].Selected == true)
                {
                    socketClient = listSocket[i];
                    break;
                }
            }
            return;
        }

        private byte[] mySerialize(string data)
        {
            return Encoding.Unicode.GetBytes(data);
        }

    }
}
