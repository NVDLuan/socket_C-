namespace Luan_Chat
{
    partial class FrmServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSent = new System.Windows.Forms.Button();
            this.timeout = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendMuti = new System.Windows.Forms.CheckedListBox();
            this.listMess = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSent = new System.Windows.Forms.RichTextBox();
            this.mes = new System.Windows.Forms.RichTextBox();
            this.rightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShare = new System.Windows.Forms.ToolStripMenuItem();
            this.listIcons = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pnAdd = new System.Windows.Forms.Panel();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnEmoji = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightClick.SuspendLayout();
            this.pnAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSent
            // 
            this.btnSent.Image = global::Luan_Chat.Properties.Resources.icons8_email_send_30;
            this.btnSent.Location = new System.Drawing.Point(1014, 561);
            this.btnSent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(63, 54);
            this.btnSent.TabIndex = 2;
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 625);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.sendMuti);
            this.panel2.Controls.Add(this.listMess);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(97, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 625);
            this.panel2.TabIndex = 4;
            // 
            // sendMuti
            // 
            this.sendMuti.FormattingEnabled = true;
            this.sendMuti.Location = new System.Drawing.Point(3, 95);
            this.sendMuti.Name = "sendMuti";
            this.sendMuti.Size = new System.Drawing.Size(401, 381);
            this.sendMuti.TabIndex = 3;
            this.sendMuti.Visible = false;
            this.sendMuti.SelectedIndexChanged += new System.EventHandler(this.sendMuti_SelectedIndexChanged);
            // 
            // listMess
            // 
            this.listMess.HideSelection = false;
            this.listMess.Location = new System.Drawing.Point(3, 95);
            this.listMess.Name = "listMess";
            this.listMess.Size = new System.Drawing.Size(400, 382);
            this.listMess.TabIndex = 2;
            this.listMess.UseCompatibleStateImageBehavior = false;
            this.listMess.View = System.Windows.Forms.View.List;
            this.listMess.SelectedIndexChanged += new System.EventHandler(this.listMess_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 92);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = global::Luan_Chat.Properties.Resources.icons8_compose_30;
            this.button1.Location = new System.Drawing.Point(325, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 46);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chats";
            // 
            // txtSent
            // 
            this.txtSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSent.Location = new System.Drawing.Point(667, 561);
            this.txtSent.Name = "txtSent";
            this.txtSent.Size = new System.Drawing.Size(332, 54);
            this.txtSent.TabIndex = 5;
            this.txtSent.Text = "";
            // 
            // mes
            // 
            this.mes.ContextMenuStrip = this.rightClick;
            this.mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes.Location = new System.Drawing.Point(598, 26);
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Size = new System.Drawing.Size(479, 528);
            this.mes.TabIndex = 10;
            this.mes.Text = "  ";
            // 
            // rightClick
            // 
            this.rightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRemove,
            this.tsShare});
            this.rightClick.Name = "rightClick";
            this.rightClick.Size = new System.Drawing.Size(133, 52);
            // 
            // tsRemove
            // 
            this.tsRemove.Name = "tsRemove";
            this.tsRemove.Size = new System.Drawing.Size(132, 24);
            this.tsRemove.Text = "Remove";
            this.tsRemove.Click += new System.EventHandler(this.tsRemove_Click);
            // 
            // tsShare
            // 
            this.tsShare.Name = "tsShare";
            this.tsShare.Size = new System.Drawing.Size(132, 24);
            this.tsShare.Text = "Share";
            // 
            // listIcons
            // 
            this.listIcons.HideSelection = false;
            this.listIcons.Location = new System.Drawing.Point(600, 313);
            this.listIcons.Name = "listIcons";
            this.listIcons.Size = new System.Drawing.Size(378, 164);
            this.listIcons.TabIndex = 12;
            this.listIcons.UseCompatibleStateImageBehavior = false;
            this.listIcons.Visible = false;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnAdd
            // 
            this.pnAdd.BackColor = System.Drawing.Color.White;
            this.pnAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnAdd.Controls.Add(this.btnFile);
            this.pnAdd.Controls.Add(this.btnEmoji);
            this.pnAdd.Controls.Add(this.btnImage);
            this.pnAdd.Location = new System.Drawing.Point(598, 483);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(248, 74);
            this.pnAdd.TabIndex = 2;
            this.pnAdd.Visible = false;
            // 
            // btnFile
            // 
            this.btnFile.Image = global::Luan_Chat.Properties.Resources.icons8_add_file_30;
            this.btnFile.Location = new System.Drawing.Point(165, 6);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 61);
            this.btnFile.TabIndex = 2;
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // btnEmoji
            // 
            this.btnEmoji.Image = global::Luan_Chat.Properties.Resources.icons8_emojis_64;
            this.btnEmoji.Location = new System.Drawing.Point(84, 6);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(75, 61);
            this.btnEmoji.TabIndex = 1;
            this.btnEmoji.UseVisualStyleBackColor = true;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // btnImage
            // 
            this.btnImage.Image = global::Luan_Chat.Properties.Resources.icons8_image_48;
            this.btnImage.Location = new System.Drawing.Point(3, 6);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 61);
            this.btnImage.TabIndex = 0;
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Luan_Chat.Properties.Resources.icons8_add_48;
            this.button2.Location = new System.Drawing.Point(598, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 54);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmServer
            // 
            this.AcceptButton = this.btnSent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 625);
            this.ContextMenuStrip = this.rightClick;
            this.Controls.Add(this.pnAdd);
            this.Controls.Add(this.listIcons);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmServer";
            this.Text = "ChatServer";
            this.Load += new System.EventHandler(this.FrmServer_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.rightClick.ResumeLayout(false);
            this.pnAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Timer timeout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtSent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox mes;
        private System.Windows.Forms.ContextMenuStrip rightClick;
        private System.Windows.Forms.ToolStripMenuItem tsRemove;
        private System.Windows.Forms.ToolStripMenuItem tsShare;
        private System.Windows.Forms.ListView listIcons;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel pnAdd;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnEmoji;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ListView listMess;
        private System.Windows.Forms.CheckedListBox sendMuti;
    }
}

