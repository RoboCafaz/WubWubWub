using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Firedodger.Constants;

namespace Firedodger.Handlers
{
    class SoundHandler
    {
        private static List<Song> _bgm = new List<Song>();
        private static List<SoundEffect> _sfx = new List<SoundEffect>();
        private static List<SoundID> _sfxIds = new List<SoundID>();
        private static KeyboardState keystate;

        public static void Add(Song song)
        {
            _bgm.Add(song);
        }

        public static void Add(SoundID soundId, SoundEffect effect)
        {
            _sfxIds.Add(soundId);
            _sfx.Add(effect);
        }

        public static Song GetSong(int id)
        {
            return _bgm.ElementAt(id);
        }

        public static SoundEffect GetSound(int id)
        {
            return _sfx.ElementAt(id);
        }

        public static void PlaySound(SoundID soundId)
        {
            int i = _sfxIds.IndexOf(soundId);
            SoundEffect effect = _sfx.ElementAt(i);
            SoundEffectInstance sound = effect.CreateInstance();
            sound.Play();
        }

        public static void Initialize()
        {
        }

        public static void Update(GameTime gameTime)
        {
            if (!MediaPlayer.State.Equals(MediaState.Playing))
            {
                MediaPlayer.Volume = 0.8f;
                MediaPlayer.Play(_bgm.ElementAt(GameObjectHandler.random.Next(0, _bgm.Count - 1)));
            }
            else
            {
                Game1.songTime = MediaPlayer.PlayPosition.TotalSeconds;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && !Keyboard.GetState().Equals(keystate))
            {
                Console.Out.WriteLine(Game1.songTime);
            }
            keystate = Keyboard.GetState();
        }

        public static void LoadContent(ContentManager Content)
        {
            Add(Content.Load<Song>("Audio/Music/Excision"));
            Add(SoundID.FIRE_ONE,Content.Load<SoundEffect>("Audio/Sound/fire1"));
            Add(SoundID.FIRE_TWO, Content.Load<SoundEffect>("Audio/Sound/fire2"));
            Add(SoundID.SCORE, Content.Load<SoundEffect>("Audio/Sound/score"));
        }
    }
}
