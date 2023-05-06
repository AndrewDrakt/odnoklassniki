/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace odnoklassniki
{
    public class TCPip
    {
        private TcpListener _listener;
        private List<TcpClient> _clients = new List<TcpClient>();
        private CancellationTokenSource _cancellationTokenSource;

        public event EventHandler<MessageReceivedEventArgs> MessageReceived;
        public event EventHandler<ClientConnectedEventArgs> ClientConnected;
        public event EventHandler<ClientDisconnectedEventArgs> ClientDisconnected;
        public event EventHandler UserListChanged;

        public bool Active => _listener != null && _listener.Server.IsBound;
        public IReadOnlyList<TcpClient> Clients => _clients.AsReadOnly();

        public async Task StartAsync(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _cancellationTokenSource = new CancellationTokenSource();
            _listener.Start();
            await AcceptClientsAsync(_cancellationTokenSource.Token);
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
            _listener.Stop();
            _clients.Clear();
        }

        private async Task AcceptClientsAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                TcpClient client = await _listener.AcceptTcpClientAsync();
                _clients.Add(client);
                ClientConnected?.Invoke(this, new ClientConnectedEventArgs(client));
                UserListChanged?.Invoke(this, EventArgs.Empty);
                _ = HandleClientAsync(client, cancellationToken); x`

            }
        }

        private async Task HandleClientAsync(TcpClient client, CancellationToken cancellationToken)
        {
            using (NetworkStream stream = client.GetStream())
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                try
                {
                    while (!cancellationToken.IsCancellationRequested && (bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)) > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        MessageReceived?.Invoke(this, new MessageReceivedEventArgs(client, message));
                    }
                }
                catch (IOException) { }
                catch (OperationCanceledException) { }

                _clients.Remove(client);
                UserListChanged?.Invoke(this, EventArgs.Empty);
                ClientDisconnected?.Invoke(this, new ClientDisconnectedEventArgs(client));
            }
        }
    }
}
*/