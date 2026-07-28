namespace OnlineShopTemplate.Models
{
    public class Product(int id, string name, decimal cost, string? description)
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public decimal Cost { get; } = cost;
        public string? Description { get; } = description;
        public string? PhotoPath { get; } = "https://avatars.mds.yandex.net/i?id=0397643ca2b187f1bdc7743a46a51f82_l-5238850-images-thumbs&n=13";

        public override string ToString() => $"{Id}{Environment.NewLine}{Name}{Environment.NewLine}{Cost:c}";
    }
}