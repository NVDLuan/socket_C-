using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Drawing.Text;
using System.Threading;
using System.IO;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChatClient
{
    public partial class ChatClient : Form
    {
        public ChatClient()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            chenEmoji();
        }
        Socket socketClient;
        IPEndPoint endpoint;
        IPAddress ip;
        int port = 3110;
        private void connectSocket()
        {
            Random r = new Random();
            
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ip = IPAddress.Parse("127.0.0."+ ((r.Next(100)+1).ToString()));
            //ip = IPAddress.Parse("127.0.0.1");
            endpoint = new IPEndPoint(ip, port);
            socketClient.Connect(endpoint);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connectSocket();
            Thread thread = new Thread(() => {

                try
                {
                    while (true)
                    {
                        byte[] buffer = new byte[1024 * 1024 * 5];
                       
                        if (socketClient.Receive(buffer) != 0)
                        {
                            if (IsValidImage(buffer))
                            {
                                Image image = (Image)byteArrayToImage(buffer);
                                Clipboard.SetImage(image);
                                message.AppendText((message.Text == "" ? "" : "\n\n") + "server" + "\t" + DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy") + "\n");
                                message.ReadOnly = false;
                                message.Select(message.Text.ToString().Length, 0);
                                message.Paste();
                                message.AppendText("\n");
                                message.ReadOnly = true;
                                //MessageBox.Show("gởi ảnh thành công!");
                            }
                            else
                            {
                                string tmp = myDeserialize(buffer);
                                if (tmp.Length > 12 && tmp.Substring(0, 12) == "listClients:")
                                {
                                    string[] listIp = tmp.Substring(13).Split(',');
                                    //MessageBox.Show(listIp.Length.ToString());
                                    listMest.Items.Clear();
                                    for(int i = 0; i< listIp.Length-1; i++)
                                    {
                                        if (listIp[i]!= socketClient.LocalEndPoint.ToString())
                                            listMest.Items.Add(listIp[i]);
                                    }
        
                                }
                                else
                                {
                                    //MessageBox.Show(tmp.Substring(0, 11));
                                    message.AppendText((message.Text == "" ? "" : "\n\n") + "server" + "\t" + DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy") + "\n\t" + myDeserialize(buffer));
                                }
                            }
                        }
                    }

                }
                catch
                {
                    socketClient.Close();
                }

            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        string path="";
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);

            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private string ImageToBase64(string path)
        {
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        private bool IsValidImage(byte[] bytes)
        {
            try
            {
                using(MemoryStream ms = new MemoryStream(bytes))
                    Image.FromStream(ms);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        // giai nen 1 mang byte thanh 1 doi tuong (bject)
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }
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
            }
            /*OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                socketClient.SendFile(ofd.FileName);
            }*/
        }
        private string myDeserialize(byte[] bytes)
        {
            return Encoding.Unicode.GetString(bytes, 0, bytes.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectSocket();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                Image image = Image.FromFile(path);
                byte[] data = new byte[1024 * 10000];
                data = ImageToByteArray(image);
                socketClient.Send(data);
                message.AppendText( (message.Text == "" ? "" : "\n\n") + "Tôi" + "\t" + DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy") + "\n");
                message.AppendText("\n");
                message.ReadOnly = false;
                //message.Select(message.Text.ToString().Length, 0);
                message.Paste();
                message.ReadOnly = true;
                path = "";
                txtSent.Text = "";
            }
            else
            {
                mySent();
                message.AppendText((message.Text == "" ? "" : "\n\n") + "Tôi" + "\t" + DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy") + "\n\t" + txtSent.Text);
            }
        }
        private void mySent()
        {
            byte[] data = new byte[1024 * 1024 * 10];
            
            socketClient.Send(mySerialize(txtSent.Text.ToString()));
        }    
        private byte[] mySerialize(string data)
        {
            return Encoding.Unicode.GetBytes(data);
        }

        private void ChatClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            //socketClient.Send(mySerialize("--%EXIT%--"));
            socketClient.Close();
        }
        private void pullFile(string path)
        {
            //path = path.Replace("\\", "/");
            byte[] clientData = new byte[1024 * 5 * 1024];
            int receiveByteLen = socketClient.Receive(clientData);
            int nameLen = BitConverter.ToInt32(clientData, 0);
            string fName =Encoding.ASCII.GetString(clientData, 4, nameLen);
            BinaryWriter writer = new BinaryWriter(File.Open(path + "\\" + fName, FileMode.Append));
            writer.Write(clientData, 4+nameLen, receiveByteLen-4-nameLen);
            writer.Close();
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            _ = listIcons.Visible == true ? listIcons.Visible = false : listIcons.Visible = true;
        }
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
                imageList1.Images.Add(img); // bỏ vào img list
            }
            this.listIcons.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(32, 32);

            this.listIcons.LargeImageList = this.imageList1;
            for (int i = 0; i < this.imageList1.Images.Count; i++)
            {
                this.listIcons.Items.Add(" ", i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ = pnAdd.Visible == true ? pnAdd.Visible = false : pnAdd.Visible = true;
        }
    }
}
