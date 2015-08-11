﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail
{
    class Messages
    {
        #region Neutral/System messages
        public class ContinueProcessing { }
        #endregion

        #region Success Messages
        public class InputSuccess
        {
            public InputSuccess(string reason)
            {
                Reason = reason;
            }

            public string Reason { get; private set; }
        }
        #endregion


        #region Error Messages
        public class InputError
        {
            public InputError(string reason)
            {
                Reason = reason;
            }

            public string Reason { get; private set; }
        }

        public class NullInputError : InputError
        {
            public NullInputError(string reason) : base(reason)
            {

            }
        }

        public class ValidationError : InputError
        {
            public ValidationError(string reason) : base(reason)
            {

            }
        }
        #endregion
    }
}
