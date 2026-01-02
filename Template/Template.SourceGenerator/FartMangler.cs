using Microsoft.CodeAnalysis;
using System.Linq;

namespace Template.SourceGenerator
{
    [Generator]
    public class FartMangler : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            IncrementalValuesProvider<string> files = context.AdditionalTextsProvider
                .Where(file => file.Path.EndsWith("i_hate_dolphins.txt"))
                .Select((file, text) => file.GetText(text)?.ToString());

            context.RegisterSourceOutput(files, (sourceProductionContext, content) =>
            {
                if (string.IsNullOrEmpty(content))
                    return;

                string generatedFile = $"// ----- Generated\r\n\r\nnamespace Template;\r\n\r\ninternal static class Hello\r\n{{\r\n\tpublic static readonly string ItsMe = \"{content}\";\r\n}}";
                sourceProductionContext.AddSource("Kawaii.g.cs", generatedFile);
            });
        }
    }
}
