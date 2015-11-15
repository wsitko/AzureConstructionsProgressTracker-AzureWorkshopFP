# Projekt treningowy do warsztatu "Wykorzystanie usług Azure do budowania skalowalnych systemów" 

Warsztat dla: [Future Processing](https://www.future-processing.pl/)

Warsztat w wersji 7h

## Instrukcja

### Zadanie 1 - prosta aplikacja na Azure

- Stwórz dwie usługi: Azure Web App oraz Azure SQL Database.
- Stwórz fork tego repozytorium na własne konto GitHub.
- Uruchom aplikację z tego repozytorium, wykorzystując funkcję Continuous Deployment, usługi Web App.
- Skonfiguruj Web App, aby korzystała ze stworzonej SQL Database (nadpisz connection string w ustawieniach Web App).

Kryteria akceptacji:
- Potrafisz urochumić aplikację i dodać nowy projekt do systemu.

### Zadanie 2 - storage


``` git 
git checkout ex-2-start-storage 

```

- Załóż usługe Storage Account.
- Przy pomocy [Azure Storage Explorer](https://azurestorageexplorer.codeplex.com/) dodaj dowolny plik i pobrać go z portalu Azure.
- W repozytorium przełączyć się na branch: 
- Uzupełnij implentację klasy FilesStorageService, tak aby zapisywała ona pliki w Azure Storage i zwracała adres nowego bloba (skorzystaj z podpowiedzi w kodzie)

Kryteria akceptacji:
- Potrafisz dodać nowy wpis ze zdjęciem do dziennika projektu oraz wyświetlić to zdjęcie na liście wpisów.

