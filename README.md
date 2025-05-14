# Dialog System Architecture (Bot Framework + CLU)

This project showcases a modular, reusable dialog management system using Microsoft's Bot Framework SDK and Azure Conversational Language Understanding (CLU).

## Features

- Modular Waterfall Dialogs
- CLU-powered entity & intent detection
- Production-ready project structure


## Setup

1. Add your CLU config to `appsettings.json` or use User Secrets.
2. Run:
```bash
dotnet restore
dotnet run
```


🌐 Try the API
Once running, access:

```bash
https://localhost:5001/swagger
```
Test /analyze, /start, etc.

Security
⚠️ Never commit API keys.
Use .gitignore or dotnet user-secrets.

MIT License · Created by @SeyitDax