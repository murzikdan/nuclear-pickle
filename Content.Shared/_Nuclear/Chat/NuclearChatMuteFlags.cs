using System;

namespace Content.Shared._Nuclear.Chat;

[Flags]
public enum NuclearChatMuteFlags : byte
{
    None = 0,
    Looc = 1 << 0,
    Ooc = 1 << 1,
    Dead = 1 << 2,
    All = Looc | Ooc | Dead
}
