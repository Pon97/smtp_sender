using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;

namespace mail
	{
		class proga
			{
			static void Main(string[] args)
				{
	//��� ��� �������� ������ � ���������:
	//��������� SMTP ������ � ������������.
	SmtpClient Smtp_Client = new SmtpClient("10.12.18.240", 25);
//��������� ��� �������� SSL - (�������� ��� ����� ������ ���� �������).
Smtp_Client.EnableSsl = false;

//���������� � ������������ ������ ������
MailMessage Message = new MailMessage();
Message.From = new MailAddress("HP2055-ITC-1FLOOR@rusal.com");
Message.To.Add(new MailAddress("dmitriy.belorukov@rusal.com"));
Message.Subject = "scan";
Message.Body = "��� �����";
string file = "C:\Pon\mai\1.jpg";
attachment attach = new attachment(file, Mediatypenames.aplication.octet);

//������ ��������� ���� � ���������...                
Smtp_Client.Send(Message);//��������������� ���� �����������...
}
}
}