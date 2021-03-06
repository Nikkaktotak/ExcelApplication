//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Nika\ExcelApplication\ExcelApplication.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ExcelApplication {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ExcelApplicationParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IExcelApplicationListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpr([NotNull] ExcelApplicationParser.ParenthesizedExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpr([NotNull] ExcelApplicationParser.ParenthesizedExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExponentialExpr([NotNull] ExcelApplicationParser.ExponentialExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExponentialExpr([NotNull] ExcelApplicationParser.ExponentialExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ModDivExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModDivExpr([NotNull] ExcelApplicationParser.ModDivExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ModDivExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModDivExpr([NotNull] ExcelApplicationParser.ModDivExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpr([NotNull] ExcelApplicationParser.MultiplicativeExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpr([NotNull] ExcelApplicationParser.MultiplicativeExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpr([NotNull] ExcelApplicationParser.AdditiveExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpr([NotNull] ExcelApplicationParser.AdditiveExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MminMmaxExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMminMmaxExpr([NotNull] ExcelApplicationParser.MminMmaxExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MminMmaxExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMminMmaxExpr([NotNull] ExcelApplicationParser.MminMmaxExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberExpr([NotNull] ExcelApplicationParser.NumberExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberExpr([NotNull] ExcelApplicationParser.NumberExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpr([NotNull] ExcelApplicationParser.IdentifierExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpr([NotNull] ExcelApplicationParser.IdentifierExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ExcelApplicationParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] ExcelApplicationParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExcelApplicationParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] ExcelApplicationParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] ExcelApplicationParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExcelApplicationParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] ExcelApplicationParser.ExpressionContext context);
}
} // namespace ExcelApplication
