using System;
using System.Collections.Generic;
using System.Text;
using L6.Inputs;
using L6.Models;
using Lab6.Inputs;

namespace L6.Outputs
{

    public static partial class CreateReplyResult
    {
        public interface ICreateReplyResult { }

        public class ReplyValid : ICreateReplyResult
        {
            public Reply Reply { get; }

            public ReplyValid(Reply reply)
            {
                Reply = reply;
            }
        }

        public class ReplyInvalid : ICreateReplyResult
        {
            public string Reasons { get; }

            public ReplyInvalid(string reasons)
            {
                Reasons = reasons;
            }
        }

        public interface IValidateReplyResult
        {
        }
        public class InvalidRequest : IValidateReplyResult
        {
            public string ValidationErrors { get; }
            public CreateReplyCmd Cmd { get; }

            public InvalidRequest(string validationErrors, CreateReplyCmd cmd)
            {
                ValidationErrors = validationErrors;
                Cmd = cmd;
            }
        }

    }

}
