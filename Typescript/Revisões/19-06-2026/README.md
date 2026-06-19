inicio do projeto
npm init
tsc --init

eslint e prettier
npm install -D eslint @eslint/js typescript-eslint prettier eslint-config-prettier

configurando o eslint e prettir

criar arquivos settings.json e eslint.config.mjs

comandos:

json prettier:
{
  "editor.formatOnSave": true,
  "editor.defaultFormatter": "esbenp.prettier-vscode",
  "editor.codeActionsOnSave": {
    "source.fixAll.eslint": "always"
  }
}

mjs eslint:
import js from "@eslint/js";
import tseslint from "typescript-eslint";
import eslintConfigPrettier from "eslint-config-prettier";

export default [
  js.configs.recommended,
  ...tseslint.configs.recommended,
  eslintConfigPrettier,
  {
    files: ["**/*.ts"],
    languageOptions: {
      parserOptions: {
        project: "./tsconfig.json",
      },
    },
  },
];
