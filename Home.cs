using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace Mail_Studio
{
    public partial class Home : Form
    {
        public Home()
        // https://github.com/itzplayz0001
        {
            InitializeComponent();
        }

        private void closeHolder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("services.mailstudio@gmail.com", senderName.Text);
                mail.To.Add(emailText.Text); 
                mail.Subject = Subject.Text;
                mail.Body = content.Text + "\n\nMail Studio";
                mail.IsBodyHtml = true; 

                //System.Net.Mail.Attachment attachment;
                //attachment = new System.Net.Mail.Attachment(path.Text);
                //mail.Attachments.Add(attachment);
                
                // REMOVE THE COMMENTS FOR THE FUNCTIONAL USE OF ATTACHMENTS!

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("services.mailstudio@gmail.com", "M*******"); // here M******* is the password, it's not the real one 
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Email Sent!");
            }
            catch (Exception ex)

            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong.\n\n" + ex.Message, "Mail Studio");
            }
        }

        private void addAttachment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //path.Text = openFileDialog1.FileName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/itzplayz0001");
        }
    }
}
