# Caching
- [Caching](#caching)
  - [General](#general)
  - [In-Memory cache](#in-memory-cache)
  - [Distributed cache](#distributed-cache)

## General
- Caching works best with data that changes infrequently and is expensive to generate.
- Apps should be written and tested to never depend on cached data.

## In-Memory cache
Simple caching with C# can be achieved by using [memory cache](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/memory).

> Apps running on a server farm (multiple servers) should ensure sessions are sticky when using the in-memory cache.

## Distributed cache
Distributed caching in ASP.Net Core can be achieved by using [distributed cache](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/distributed). This can be achieved e.g. by using [Redis](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/distributed#distributed-redis-cache), SQL Server or others.

When cached data is distributed, the data:
- Is coherent (consistent) across requests to multiple servers.
- Survives server restarts and app deployments.
- Doesn't use local memory.