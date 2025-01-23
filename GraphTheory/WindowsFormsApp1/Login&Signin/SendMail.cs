using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace WindowsFormsApp1.Login_Signin
{
    public static class SendMail
    {
        public static string taikhoan = "minhthinh.221005@gmail.com";
        public static string matkhau = "ymhr ysde vahv buya";
        /// <summary>
        /// Gửi mã OTP đến email dc chỉ định
        /// </summary>
        /// <param name="emailto">Email cần được gửi đi</param>
        /// <param name="content">Nội dung của email</param>
        /// <returns></returns>
        public static bool sendMailTo(string emailto , string content)
        {
            var fromAddress = new MailAddress(taikhoan, "Admin Quan Ly");
            var toAddress = new MailAddress(emailto, emailto);
            string fromPassword = matkhau;
            string subject = "Thông báo từ hệ thống dẫn đường xe cứu thương";
            string body = content;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            try {
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                return true;
            }
            catch
            {
                return false;   
            }
        }
    }
}
