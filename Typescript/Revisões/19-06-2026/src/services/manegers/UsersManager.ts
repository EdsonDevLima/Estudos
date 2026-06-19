import { WebSocket } from '@fastify/websocket';
import { IConnectedUser } from '../../types/user';
import { IUser } from '../../types/user';
import { IMessagePayload } from '../../types/message';
import { Socket } from 'node:dgram';

export class UserManager {
  private users = new Map<number, IConnectedUser>();
  add(user: IUser, socket: WebSocket) {
    this.users.set(user.id, { user, socket });
  }
  remove(userId: number) {
    this.users.delete(userId);
  }
  isOnline(userId: number) {
    this.users.has(userId);
  }
  //envio de mensagem, sem envio para o rementente
  broadcast(message: IMessagePayload, ExcludeUserId: number) {
    const payload = JSON.stringify(message);

    this.users.forEach(({ socket }, id) => {
      if (id !== ExcludeUserId && socket.readyState === 1) {
        socket.send(payload);
      }
    });
  }

  sendTo(message: IMessagePayload, toUserId: number) {
    const user = this.users.get(toUserId);
    const payload = JSON.stringify(message);
    if (user && user.socket.readyState === 1) {
      user.socket.send(payload);
    }
  }
}
