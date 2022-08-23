namespace P038_Praktika.Models
{
    public class Hobby
    {
        public Hobby()
        {
        }

        public Hobby(int id, string text, string textLt)
        {
            Id = id;
            Text = text;
            TextLt = textLt;
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public string TextLt { get; set; }

        public void UzpildytiHobioProperties(string value)
        {
            int stulpeliuSkLaikmenoje = 3;

            var arr = value.Split(",");
            if (arr.Length != stulpeliuSkLaikmenoje)
            {
                return;
            }
            if (!int.TryParse(arr[0], out int id))
            {
                return;
            }

            Id = id;
            Text = arr[1];
            TextLt = arr[2];

        }

        public string GetCsv() => String.Join(",", Id, Text, TextLt);
    }
}
