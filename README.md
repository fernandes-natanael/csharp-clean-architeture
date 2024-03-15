
```bash
dotnet ef migrations add Inicial --project .\CleanArchMvc.Infra.Data -s .\CleanArchMvc.WebUI -c ApplicationDbContext

dotnet ef database update --project .\CleanArchMvc.Infra.Data -s .\CleanArchMvc.WebUI -c ApplicationDbContext
```