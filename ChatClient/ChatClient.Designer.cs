namespace ChatClient
{
    partial class ChatClient
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
            this.txtSent = new System.Windows.Forms.RichTextBox();
            this.message = new System.Windows.Forms.RichTextBox();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.listIcons = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnEmoji = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listMest = new System.Windows.Forms.ListView();
            this.pnAdd.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSent
            // 
            this.txtSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSent.Location = new System.Drawing.Point(526, 480);
            this.txtSent.Name = "txtSent";
            this.txtSent.Size = new System.Drawing.Size(332, 54);
            this.txtSent.TabIndex = 8;
            this.txtSent.Text = "";
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(457, 12);
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Size = new System.Drawing.Size(479, 461);
            this.message.TabIndex = 10;
            this.message.Text = "";
            // 
            // pnAdd
            // 
            this.pnAdd.BackColor = System.Drawing.Color.White;
            this.pnAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnAdd.Controls.Add(this.btnFile);
            this.pnAdd.Controls.Add(this.btnEmoji);
            this.pnAdd.Controls.Add(this.btnImage);
            this.pnAdd.Location = new System.Drawing.Point(457, 397);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(248, 74);
            this.pnAdd.TabIndex = 13;
            this.pnAdd.Visible = false;
            // 
            // listIcons
            // 
            this.listIcons.HideSelection = false;
            this.listIcons.Location = new System.Drawing.Point(457, 227);
            this.listIcons.Name = "listIcons";
            this.listIcons.Size = new System.Drawing.Size(378, 164);
            this.listIcons.TabIndex = 14;
            this.listIcons.UseCompatibleStateImageBehavior = false;
            this.listIcons.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 554);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 92);
            this.panel3.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(97, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 554);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.listMest);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 462);
            this.panel4.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSent
            // 
            this.btnSent.Image = global::ChatClient.Properties.Resources.icons8_email_send_30;
            this.btnSent.Location = new System.Drawing.Point(873, 480);
            this.btnSent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(63, 54);
            this.btnSent.TabIndex = 7;
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ChatClient.Properties.Resources.icons8_compose_30;
            this.button1.Location = new System.Drawing.Point(265, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 46);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFile
            // 
            this.btnFile.Image = global::ChatClient.Properties.Resources.icons8_add_file_30;
            this.btnFile.Location = new System.Drawing.Point(165, 6);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 61);
            this.btnFile.TabIndex = 2;
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // btnEmoji
            // 
            this.btnEmoji.Image = global::ChatClient.Properties.Resources.icons8_emojis_64;
            this.btnEmoji.Location = new System.Drawing.Point(84, 6);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(75, 61);
            this.btnEmoji.TabIndex = 1;
            this.btnEmoji.UseVisualStyleBackColor = true;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // btnImage
            // 
            this.btnImage.Image = global::ChatClient.Properties.Resources.icons8_image_48;
            this.btnImage.Location = new System.Drawing.Point(3, 6);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 61);
            this.btnImage.TabIndex = 0;
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ChatClient.Properties.Resources.icons8_add_48;
            this.button2.Location = new System.Drawing.Point(457, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 54);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listMest
            // 
            this.listMest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMest.HideSelection = false;
            this.listMest.Location = new System.Drawing.Point(4, 4);
            this.listMest.Name = "listMest";
            this.listMest.Size = new System.Drawing.Size(341, 457);
            this.listMest.TabIndex = 0;
            this.listMest.UseCompatibleStateImageBehavior = false;
            // 
            // ChatClient
            // 
            this.AcceptButton = this.btnSent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnAdd);
            this.Controls.Add(this.listIcons);
            this.Controls.Add(this.message);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSent);
            this.Controls.Add(this.btnSent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChatClient";
            this.Text = "ChatClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatClient_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnAdd.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtSent;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.Panel pnAdd;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnEmoji;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ListView listIcons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listMest;
    }
}

