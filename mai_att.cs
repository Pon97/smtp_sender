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
	//Сам код отправки письма с вложением:
	//Указываем SMTP сервер и авторизуемся.
	SmtpClient Smtp_Client = new SmtpClient("10.12.18.240", 25);
//Выключаем или включаем SSL - (например для гугла должен быть включен).
Smtp_Client.EnableSsl = false;

//Приступаем к формированию самого письма
MailMessage Message = new MailMessage();
Message.From = new MailAddress("HP2055-ITC-1FLOOR@rusal.com");
Message.To.Add(new MailAddress("dmitriy.belorukov@rusal.com"));
Message.Subject = "scan";
Message.Body = "нет скана";
string file = "C:\Pon\mai\1.jpg";
attachment attach = new attachment(file, Mediatypenames.aplication.octet);

//Теперь прикрепим файл к сообщению...                
Smtp_Client.Send(Message);//непосредственно само отправление...
}
}
}