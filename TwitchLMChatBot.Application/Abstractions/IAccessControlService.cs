﻿using TwitchLMChatBot.Application.Services;
using TwitchLMChatBot.Models;

namespace TwitchLMChatBot.Application.Abstractions
{
    public interface IAccessControlService
    {
        bool Check(CheckAccessRequest checkRequest);
        AccessControl Get();
        void Set(SetAccessControlRequest request);
    }
}