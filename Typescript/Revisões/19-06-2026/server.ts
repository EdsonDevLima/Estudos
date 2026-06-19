import fastify from 'fastify';
import webSocket from '@fastify/websocket';
import 'dotenv/config';

const app = fastify();
app.register(webSocket);

app.listen({ port: 3000, host: 'localhost' });
