# REPRO

Clone the repo, run `dotnet restore`, `dotnet build`
Observe everything builds

Delete `<PackageReference Include="Microsoft.Azure.WebJobs" Version="3.0.33" />` from `CodeAnalysisDisappearing.csproj`
Build again, observe build failure

Why does presence of `Microsoft.Azure.WebJobs` suppresses certain code analysis rules?
I haven't observed build assets that are getting pulled with this package, or specific rulesets