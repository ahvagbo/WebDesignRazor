using Microsoft.Extensions.ObjectPool;
using System.IO;

namespace WebDesignRazor;

public static class HtmlCodeHelper
{
    public static string ReadHtml(string htmlFile, int indexStart, int indexEnd)
    {
        string[] code = File.ReadAllLines(htmlFile);
        return string.Join("\r\n", code[indexStart..indexEnd]);
    }
}
