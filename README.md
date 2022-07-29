# read_calendars_c_sharp

This sample will show you to easily read all your calendars using the Calendars Endpoint API.

## Setup

```bash
$ mkdir read_calendars && cd read_calendars

$ dotnet new console
```

### System dependencies

- RestSharp
- DotNetEnv

### Gather environment variables

You'll need the following values:

```text
ACCESS_TOKEN = ""
```

Add the above values to a new `.env` file:

```bash
$ touch .env # Then add your env variables
```

# Compilation

To compile the comment we need to use this `dotnet` command:

```bash
$ dotnet run --project read_calendars.csproj
```

## Usage

Run the app:

```bash
$ ./bin/Debug/net6.0/read_calendars
```

When you run it, it will display all your calendars and wait for a keystoke to end


## Learn more

Visit our [Nylas Calendar API documentation](https://developer.nylas.com/docs/connectivity/calendar/) to learn more.
