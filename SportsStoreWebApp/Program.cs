Console.WriteLine("---Thuc hanh C# co ban---");

List<SportsStoreWebApp.Models.Product> sampleProducts = new List<SportsStoreWebApp.Models.Product>
{
    new SportsStoreWebApp.Models.Product { ProductID = 1, Name = "Bóng đá WorldCup", Description = "Bóng đá chính hãng", Price = 50.00m, Category = "Bóng đá" },
    new SportsStoreWebApp.Models.Product { ProductID = 2, Name = "Áo đấu CLB A",Description = "Áo đấu cho người hâm mộ", Price = 75.50m, Category = "Quần áo" },
    new SportsStoreWebApp.Models.Product { ProductID = 3, Name = "Vợt TennisPro", Description = "Vợt chuyên nghiệp", Price = 150.00m, Category = "Tennis" },
    new SportsStoreWebApp.Models.Product { ProductID = 4, Name = "Giày chạy bộABC", Description = "Giày thể thao nhẹ", Price = 99.99m, Category = "Giày" },
    new SportsStoreWebApp.Models.Product { ProductID = 5, Name = "Bóng rổ NBA",Description = "Bóng rổ tiêu chuẩn", Price = 45.00m, Category = "Bóng rổ" }
};
Console.WriteLine("\n--- LINQ: Lọc sản phẩm có giá trên 70 ---");
var expensiveProducts = sampleProducts.Where(p => p.Price > 70.00m);
foreach (var p in expensiveProducts)
{
    Console.WriteLine($"- {p.Name} ({p.Price:C})");
}
Console.WriteLine("\n--- LINQ: Lấy sản phẩm đầu tiên thuộc danh mục 'Bóng đá' ---");
var firstFootballProduct = sampleProducts.FirstOrDefault(p => p.Category == "Bóngđá");
if (firstFootballProduct != null)
{
    Console.WriteLine($"- {firstFootballProduct.Name}");
}
else
{
    Console.WriteLine("Không tìm thấy sản phẩm bóng đá.");
}
Console.WriteLine("\n--- Async/Await: Mô phỏng thao tác bất đồng bộ ---");
async Task SimulateDataFetchAsync()
{
    Console.WriteLine("Đang bắt đầu lấy dữ liệu (mất 2 giây)...");
    await Task.Delay(2000); // Mô phỏng thao tác tốn thời gian
    Console.WriteLine("Đã lấy xong dữ liệu.");
}
// Gọi hàm bất đồng bộ
await SimulateDataFetchAsync(); // Cần `await` ở đây vì hàm Main của .NET 6+ đãlà async
Console.WriteLine("--- Kết thúc thực hành C# cơ bản ---\n");
// --- Kết thúc phần thực hành C# cơ bản ---