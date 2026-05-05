namespace pjpProject;

using Antlr4.Runtime;

public class ErrorCollector : IAntlrErrorListener<IToken>, IAntlrErrorListener<int>
{
    public List<string> Errors { get; } = new();

    // parser
    public void SyntaxError(System.IO.TextWriter output, IRecognizer recognizer,
        IToken offendingSymbol, int line, int charPositionInLine, string msg,
        RecognitionException e)
        => Errors.Add($"Line {line}:{charPositionInLine} {msg}");

    // lexer
    public void SyntaxError(System.IO.TextWriter output, IRecognizer recognizer,
        int offendingSymbol, int line, int charPositionInLine, string msg,
        RecognitionException e)
        => Errors.Add($"Line {line}:{charPositionInLine} {msg}");
}
