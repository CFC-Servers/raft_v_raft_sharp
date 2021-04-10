using Sandbox;

namespace RaftVRaft {
    [ClassLibrary("raft-v-raft", Title="Raft v Raft")]
    partial class Game : Sandbox.Game {
        public static Game Instance {
            get => Current as game;
        }
    }
}
