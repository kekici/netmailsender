netmailsender
=============

NetMail Sender is a tool to help test the System.Net.Mail API.  It is basically an email sender and there are two goals I have for this tool. 

1. To provide a way to test sending mail using the System.Net.Mail API for troubleshooting purposes.
2. To provide sample code as an example of how you can possibly make use of the API.

![ScreenShot](http://i.imgur.com/bOdaQoG.jpg)

Download the application executable [here](https://github.com/desjarlais/netmailsender/releases/tag/1.4.0.15).

Features include:

•	Send email
•	Add custom header(s)
•	Add attachment(s)
•	Add Alternate views (html and plain text)
•	Add LinkedResource / Inline attachment
•	Set message priority
•	Use html body for message
•	Use read receipt
•	Send by port
•	Send by pickup folder
•	Send message every ‘x’ number of seconds
•	Send to multiple recipients (To, Cc, Bcc)
•	Adjust file attachment content type
•	Adjust message encoding
•	Send calendar appointments
•	Error logging

Minimum Requirements
•	Microsoft .NET Framework Version 4.5.2

Since this tool is just a mail sender, if you are looking for a tool that will retrieve information from a Microsoft Exchange mailbox it would be worth checking out [EWSEditor](https://github.com/dseph/EwsEditor).

If you are looking for a tool that provides access to MAPI stores to facilitate investigation of Microsoft Exchange and Microsoft Outlook issues, I would recommend [MFCMAPI](https://github.com/stephenegriffin/mfcmapi).
