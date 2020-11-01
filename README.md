# adotimetravel
ADO dot net example

Demonstrates how to do ADO DOT NET using the old method before ORMs

# What you will learn?

1. How to connect your database to a console application. 
2. What an ORM is.
3. The basics of networking

# Prequistes 

0. Know what OS they are using
1. VSCode installed
2. Postgres installed
3. dotnet core installed

# Following are instructions to create the project from scratch

Create a new directory for the project
``` {sh }
mkdir adotimetravel
```

Then change to that directory
```
cd adotimetravel
```

Create a new console app
```
dotnet new console
```

The following adds
``` {sh add-pakckage}
dotnet add package Npgsql
```

## note

Show exceptions and how to create them

explain localhost and that 127.0.0.1 is the same as local host

# How to check your local ip address
Windows
``` {sh }
ipconfig
```
On linux OS
``` {sh}
ifconfig
```

# What is your GATEWAY?

Your default gateway will be how to get to the internet. It will be the address of your local router.

By typing this address into the address bar you will be able to access the administrator settings of your local router.

Whenever anyone in the world wants to get connected to the internet they need what is called a unique IP (Internet Protocol) address to get them there.


# On Windows do the following to get even more information on your local network setup   
``` {sh}
ipconfig /all
```

# Troubleshoot your internet

Ping loopback address
``` {sh ping}
ping 127.0.0.1
```

Ping your default gateway. N.B. * are not correct and will be replaced by your default gateway as listed after ifconfig.
``` {sh }
ping 198.168.*.*
```


