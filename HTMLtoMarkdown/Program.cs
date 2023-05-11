using Aspose.Html.Converters;
using Aspose.Html.Saving;

Console.WriteLine("Início");

//Diretório Inicial
string basePath = "C:\\repositorios\\HTMLtoMarkdown\\HTMLtoMarkdown\\";

//Arquivo a ser convertido
string InputDir = Path.Combine(basePath, "input");
string InputFile = "http3.html"; ///set file name

//Arquivo de saída
string OutputDir = Path.Combine(basePath, "output");
string savePath = Path.Combine(OutputDir, "options-output.md");

//Configurações do MD
var options = new MarkdownSaveOptions();
options.Features = MarkdownFeatures.Link | MarkdownFeatures.AutomaticParagraph | MarkdownFeatures.List | MarkdownFeatures.CodeBlock | MarkdownFeatures.InlineHTML | MarkdownFeatures.LineBreak;

//Converter HTML para MD
Converter.ConvertHTML(Path.Combine(OutputDir, Path.Combine(InputDir, InputFile)), options, savePath);

Console.WriteLine("Fim");
Console.ReadLine();