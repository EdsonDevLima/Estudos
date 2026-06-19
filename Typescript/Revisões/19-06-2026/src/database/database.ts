import { IMessagePayload } from '../types/message';
import { IUser } from '../types/user';

export const users: IUser[] = [
  {
    id: 1,
    name: 'Administrador do Sistema',
    username: 'admin',
    password: '123456',
  },
  { id: 2, name: 'João Silva', username: 'joao', password: '123456' },
  { id: 3, name: 'Maria Souza', username: 'maria', password: '123456' },
  { id: 4, name: 'Carlos Pereira', username: 'carlos', password: '123456' },
  { id: 5, name: 'Ana Oliveira', username: 'ana', password: '123456' },
];

export const rooms: Record<string, { messages: IMessagePayload[] }> = {
  generalChat: {
    messages: [
      {
        id: '1',
        userId: 2,
        username: 'joao',
        text: 'Oi pessoal!',
        createdAt: '2026-06-19T12:00:00Z',
      },
      {
        id: '2',
        userId: 3,
        username: 'maria',
        text: 'Olá João!',
        createdAt: '2026-06-19T12:01:00Z',
      },
    ],
  },
};
