﻿using System.Runtime.CompilerServices;
namespace SpreadsheetCalculator.Cells
{
    /// <summary>
    /// Describe inner SpreadsheetCell states.
    /// </summary>
    public enum CellState
    {
        /// <summary>
        /// Cell not evaluated yet.
        /// </summary>
        Pending,

        /// <summary>
        /// Cell evaluated and contains correct value.
        /// </summary>
        Fulfilled,

        /// <summary>
        /// There's something wrong with the way your formula is typed. 
        /// Or, there's something wrong with the cells you are referencing." 
        /// </summary>
        ValueError,

        /// <summary>
        /// Cell contains numeric values that aren’t valid.
        /// </summary>
        NumberError
    }
}