# FilterIssueTest
Repo to show an issue with HotChocolate.Types.Filters nuget

Query with error:
query {
  items(where: { categories_some: { name: "Cat1" }, itemSetting: { data: 123 } }) {
    id
    categories {
      name
    }
    itemSetting {
      data
    }
  }
}


Query without an error:
query {
  items(where: { itemSetting: { data: 123 }, categories_some: { name: "Cat1" } }) {
    id
    categories {
      name
    }
    itemSetting {
      data
    }
  }
}

Error itself:
{
  "errors": [
    {
      "message": "Unexpected Execution Error",
      "locations": [
        {
          "line": 2,
          "column": 3
        }
      ],
      "path": [
        "items"
      ],
      "extensions": {
        "message": "Object reference not set to an instance of an object.",
        "stackTrace": "   at lambda_method85(Closure, Item)\r\n   at System.Linq.Enumerable.WhereEnumerableIterator`1.MoveNext()\r\n   at HotChocolate.Execution.Processing.ResolverTask.<>c__DisplayClass13_0.<ExecuteResolverPipelineAsync>b__0()\r\n   at System.Threading.Tasks.Task`1.InnerInvoke()\r\n   at System.Threading.ExecutionContext.RunFromThreadPoolDispatchLoop(Thread threadPoolThread, ExecutionContext executionContext, ContextCallback callback, Object state)\r\n--- End of stack trace from previous location ---\r\n   at System.Threading.ExecutionContext.RunFromThreadPoolDispatchLoop(Thread threadPoolThread, ExecutionContext executionContext, ContextCallback callback, Object state)\r\n   at System.Threading.Tasks.Task.ExecuteWithThreadLocal(Task& currentTaskSlot, Thread threadPoolThread)\r\n--- End of stack trace from previous location ---\r\n   at HotChocolate.Execution.Processing.ResolverTask.ExecuteResolverPipelineAsync(CancellationToken cancellationToken)\r\n   at HotChocolate.Execution.Processing.ResolverTask.TryExecuteAsync(CancellationToken cancellationToken)"
      }
    }
  ],
  "data": {
    "items": null
  }
}
