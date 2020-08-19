namespace Mail_Studio
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.head = new System.Windows.Forms.Label();
            this.closeHolder = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Subject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.senderName = new System.Windows.Forms.TextBox();
            this.codeBlock = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.TextBox();
            this.addAttachment = new System.Windows.Forms.LinkLabel();
            this.path = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SendTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.closeHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.codeBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Segoe UI", 17.25F);
            this.head.ForeColor = System.Drawing.Color.White;
            this.head.Location = new System.Drawing.Point(15, 15);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(130, 31);
            this.head.TabIndex = 0;
            this.head.Text = "Mail Studio";
            // 
            // closeHolder
            // 
            this.closeHolder.Controls.Add(this.close);
            this.closeHolder.Location = new System.Drawing.Point(767, 0);
            this.closeHolder.Name = "closeHolder";
            this.closeHolder.Size = new System.Drawing.Size(25, 23);
            this.closeHolder.TabIndex = 1;
            this.closeHolder.Click += new System.EventHandler(this.closeHolder_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(4, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(11, 11);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.closeHolder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Location = new System.Drawing.Point(20, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 28);
            this.panel1.TabIndex = 2;
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.ForeColor = System.Drawing.Color.White;
            this.emailText.Location = new System.Drawing.Point(4, 3);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(258, 22);
            this.emailText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "To";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.Subject);
            this.panel2.Location = new System.Drawing.Point(20, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 28);
            this.panel2.TabIndex = 4;
            // 
            // Subject
            // 
            this.Subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.Subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Subject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.ForeColor = System.Drawing.Color.White;
            this.Subject.Location = new System.Drawing.Point(4, 3);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(258, 22);
            this.Subject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sender Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.senderName);
            this.panel3.Location = new System.Drawing.Point(20, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 28);
            this.panel3.TabIndex = 6;
            // 
            // senderName
            // 
            this.senderName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.senderName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senderName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderName.ForeColor = System.Drawing.Color.White;
            this.senderName.Location = new System.Drawing.Point(4, 3);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(258, 22);
            this.senderName.TabIndex = 3;
            // 
            // codeBlock
            // 
            this.codeBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.codeBlock.Controls.Add(this.content);
            this.codeBlock.Controls.Add(this.panel4);
            this.codeBlock.Location = new System.Drawing.Point(20, 297);
            this.codeBlock.Name = "codeBlock";
            this.codeBlock.Size = new System.Drawing.Size(753, 298);
            this.codeBlock.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.panel4.Location = new System.Drawing.Point(6, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 298);
            this.panel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(144)))));
            this.label4.Location = new System.Drawing.Point(20, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Insert code here";
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Font = new System.Drawing.Font("Consolas", 11.75F);
            this.content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(145)))), ((int)(((byte)(107)))));
            this.content.Location = new System.Drawing.Point(9, 2);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(742, 295);
            this.content.TabIndex = 10;
            // 
            // addAttachment
            // 
            this.addAttachment.AutoSize = true;
            this.addAttachment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addAttachment.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(144)))));
            this.addAttachment.Location = new System.Drawing.Point(22, 242);
            this.addAttachment.Name = "addAttachment";
            this.addAttachment.Size = new System.Drawing.Size(110, 19);
            this.addAttachment.TabIndex = 10;
            this.addAttachment.TabStop = true;
            this.addAttachment.Text = "Add Attachment";
            this.addAttachment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addAttachment_LinkClicked);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.path.ForeColor = System.Drawing.Color.White;
            this.path.Location = new System.Drawing.Point(138, 242);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(15, 19);
            this.path.TabIndex = 11;
            this.path.Text = "-";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(698, 607);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 27);
            this.send.TabIndex = 12;
            this.send.Text = "Send";
            this.SendTip.SetToolTip(this.send, "Send email");
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 605);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(792, 647);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.path);
            this.Controls.Add(this.addAttachment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codeBlock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeHolder);
            this.Controls.Add(this.head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.closeHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.codeBlock.ResumeLayout(false);
            this.codeBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Panel closeHolder;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox senderName;
        private System.Windows.Forms.Panel codeBlock;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.LinkLabel addAttachment;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ToolTip SendTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

