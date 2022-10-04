﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueServiceLibrary
{
    public interface IValueService
    {
        List<PostFactor> PostFactors { get; }

        /// <summary>
        /// Converts a number as string with/without Postfaktor to a decimal
        /// </summary>
        /// <param name="value">string of the number to convert. Can contain - , . postfactor inside or at the end of the string</param>
        /// <returns>decimal representation of the string number without power to at and postfactor</returns>
        decimal GetDecimal(string value);

        /// <summary>
        /// Converts the decimal input value to string including postfactor and a specific number of postcoma digits
        /// </summary>
        /// <param name="value">decimal value to be convertet</param>
        /// <param name="precision">number of postcoma digits (rounded)</param>
        /// <returns>string representation to use at UIs</returns>
        string GetDisplayValue(decimal value, int precision, string postFactorParam);

        /// <summary>
        /// calculate a decimal number out of a number and its postfactor (e.g. 100, = 100000)
        /// </summary>
        /// <param name="number">decimal number to multiply the postfactor to</param>
        /// <param name="postFactor">string postfactor to calculate the number</param>
        /// <returns>decimal representation of number and postfactor</returns>
        decimal Pow10PostFactor(decimal number, string postFactor);

        /// <summary>
        /// determines the potenz (10^x) from the list of postfactors
        /// </summary>
        /// <param name="value">postfactor to be searched</param>
        /// <returns>potenz x (10^x) as signed integer. null if no postfactor is found</returns>
        int? GetPotenz(string value);

        /// <summary>
        /// determines the postfactor from a given value. The optimized factor is found, when the value is bigger 0 and smaller 1000
        /// </summary>
        /// <param name="value">decimal value without postfactor</param>
        /// <returns>optimal postfactor for the value(1 character)</returns>
        string GetPostFactor(decimal value);
    }
}
 