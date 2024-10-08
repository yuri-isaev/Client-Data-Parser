using ClientDataParser.Contracts;
using ClientDataParser.Persistance;
using Microsoft.Extensions.DependencyInjection;

namespace ClientDataParser;

static class Program
{
  /// <summary>
  ///  The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main()
  {
    // Включаем визуальные стили
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    // Настройка DI
    var serviceProvider = new ServiceCollection()
      .AddScoped<AppDbContext>() // Регистрация базы данных контекста
      .AddScoped<IClientRepository, ClientRepository>() // Регистрация репозитория
      .AddScoped<MainForm>()     // Регистрация MainForm с помощью DI
      .BuildServiceProvider();

    // Получение экземпляра MainForm с инъекцией зависимостей
    var mainForm = serviceProvider.GetService<MainForm>();
    
    // Проверка, имеет ли mainForm значение null
    if (mainForm == null)
    {
      MessageBox.Show("Failed to resolve MainForm.");
      return;
    }

    Application.Run(mainForm);
  }
}
