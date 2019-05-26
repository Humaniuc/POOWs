namespace ICloneableApp
{
    class Contact
    {
        internal string Tel { get; set; }
        internal string Email { get; set; }

        internal Contact(string tel, string email)
        {
            Tel = tel;
            Email = email;
        }
    }
}
