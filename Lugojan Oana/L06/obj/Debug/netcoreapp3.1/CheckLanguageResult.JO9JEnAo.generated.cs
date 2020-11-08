// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Choices;

namespace L6.Outputs
{
    public static partial class CheckLanguageResult
    {
        public static ICheckLanguageResult Match(this ICheckLanguageResult self, System.Func<SafeText, ICheckLanguageResult> whenSafeText, System.Func<NotSafeText, ICheckLanguageResult> whenNotSafeText)
        {
            switch ((self))
            {
                case SafeText safetext:
                    return whenSafeText(safetext);
                case NotSafeText notsafetext:
                    return whenNotSafeText(notsafetext);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static async System.Threading.Tasks.Task<ICheckLanguageResult> MatchAsync(this ICheckLanguageResult self, System.Func<SafeText, System.Threading.Tasks.Task<ICheckLanguageResult>> whenSafeText, System.Func<NotSafeText, System.Threading.Tasks.Task<ICheckLanguageResult>> whenNotSafeText)
        {
            switch ((self))
            {
                case SafeText safetext:
                    return await whenSafeText(safetext);
                case NotSafeText notsafetext:
                    return await whenNotSafeText(notsafetext);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static R Match<R>(this ICheckLanguageResult self, System.Func<SafeText, R> whenSafeText, System.Func<NotSafeText, R> whenNotSafeText)
        {
            switch ((self))
            {
                case SafeText safetext:
                    return whenSafeText(safetext);
                case NotSafeText notsafetext:
                    return whenNotSafeText(notsafetext);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static async System.Threading.Tasks.Task<R> MatchAsync<R>(this ICheckLanguageResult self, System.Func<SafeText, System.Threading.Tasks.Task<R>> whenSafeText, System.Func<NotSafeText, System.Threading.Tasks.Task<R>> whenNotSafeText)
        {
            switch ((self))
            {
                case SafeText safetext:
                    return await whenSafeText(safetext);
                case NotSafeText notsafetext:
                    return await whenNotSafeText(notsafetext);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }
    }
}