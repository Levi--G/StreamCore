using Mixer.Base.Model.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCore.Chat.Mixer
{
    public class MixerUser : GenericChatUser
    {
        public string Avatar { get; set; }
        public ChatUserEventModel UserModel { get; set; }
    }
    public class MixerMessage : GenericChatMessage
    {
        public ChatMessageEventModel MessageModel { get; set; }
    }
}
