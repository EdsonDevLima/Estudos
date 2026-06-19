export interface IMessagePayload {
  id: string;
  userId: number;
  username: string;
  text: string;
  createdAt: string;
}
export interface AuthPayload {
  type: 'auth';
  username: string;
  password: string;
}

export interface GlobalMessagePayload {
  type: 'global_message';
  text: string;
}

export interface PrivateMessagePayload {
  type: 'private_message';
  toUserId: number;
  text: string;
}

export type IncomingPayload =
  | AuthPayload
  | GlobalMessagePayload
  | PrivateMessagePayload;
