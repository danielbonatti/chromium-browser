# ChromiumBrowser
Chromium - Navegador de código aberto com base no Chrome

Observações: 
 * É obrigatório adicionar a biblioteca CefSharp.WinForms ao projeto pelo gerenciador de pacotes NuGet (botão direito do mouse sob o projeto e selecione "gerenciar pacotes do NuGet...");
 * Cef.Initialize só pode ser chamado uma vez, é possível verificar Cef.IsInitialized para ver se já foi chamado. Chamá-lo em seu arquivo program.cs é uma opção.

if (!Cef.IsInitialized) // Check before init
{
  CefSettings settings = new CefSettings();
  Cef.Initialize(settings);
}
