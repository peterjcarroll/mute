using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioSwitcher.AudioApi.CoreAudio;

namespace mute
{
   class Program
   {
      static void Main(string[] args)
      {
         bool toggle = false;

         CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
         if(args.Length > 0)
         {
            switch(args[0])
            {
               case "on":
                  defaultPlaybackDevice.Mute(true);
                  break;
               case "off":
                  defaultPlaybackDevice.Mute(false);
                  break;
               default:
                  toggle = true;
                  break;
            }
         }
         else
         {
            toggle = true;
         }

         if (toggle)
         {
            defaultPlaybackDevice.ToggleMute();
         }
      }
   }
}
