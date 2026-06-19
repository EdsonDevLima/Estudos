import { WebSocket } from '@fastify/websocket';

export interface IUser {
  id: number;
  name: string;
  username: string;
  password: string;
}
export interface IConnectedUser {
  user: IUser;
  socket: WebSocket;
}
