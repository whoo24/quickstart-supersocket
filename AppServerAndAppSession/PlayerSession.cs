using SuperSocket.SocketBase;

namespace AppServerAndAppSession {
  public class PlayerSession : AppSession<PlayerSession> {
    public int GameHallId { get; internal set; }
    public int RoomId { get; internal set; }
  }
}
