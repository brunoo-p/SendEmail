namespace SendEmail.EmailBody
{
    class Body
    {
        public static string Message()
        {
            return
            @"<html>
                <h2><b> Bem-Vindo </b></h2>
                <label> Me acompanha lá. </label>
                <div> <img src= cid:ImageId /></div>
            </html>";
        }
    }
}
