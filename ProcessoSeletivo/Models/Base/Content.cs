namespace ProcessoSeletivo.Models.Base
{
    public class Content : Base
    {
        public Content(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
    }
}
