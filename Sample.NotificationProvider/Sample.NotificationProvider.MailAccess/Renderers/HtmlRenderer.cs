using RazorEngineCore;

namespace Sample.NotificationProvider.MailAccess.Renderers;

public class HtmlRenderer : IHtmlRenderer
{
    public async Task<string> RenderAsync<T>(string template, T data)
    {
        var engine = new RazorEngine();
        var compiledTemplate = await engine.CompileAsync(template);

        return await compiledTemplate.RunAsync(data);
    }
}
