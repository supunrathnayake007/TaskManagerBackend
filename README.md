# Task Manager Backend API

- [Task Manager Backend API](#task-manager-backend-api)
  - [Create Task](#create-task)
    - [Create Task Request](#create-task-request)
    - [Create Task Response](#create-task-response)
  - [Get Task](#get-task)
    - [Get Task Request](#get-task-request)
    - [Get Task Response](#get-task-response)
  - [Update Task](#update-task)
    - [Update Task Request](#update-task-request)
    - [Update Task Response](#update-task-response)
  - [Delete Task](#delete-task)
    - [Delete Task Request](#delete-task-request)
    - [Delete Task Response](#delete-task-response)

## Create Task

### Create Task Request

```js
POST /Task
```

```json
{
    "title": "Get Groceries",
    "note": "get meat , cheese , fruits and others ... ",
    "CreatedDateTime": "2022-04-08T08:00:00",   
    "isComplete":  false,
    "completeDateTime": "2022-04-08T11:00:00",
}
```
### Create Task Response

```js
201 Created
```

```yml
Location: {{host}}/Task/{{id}}
```
```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "title": "Get Groceries",
    "note": "get meat , cheese , fruits and others ... ",
    "CreatedDateTime": "2022-04-08T08:00:00",   
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "isComplete":  false,
    "completeDateTime": "2022-04-08T11:00:00",
}
```

## Get Task

### Get Task Request

```js
GET /Task/{{id}}
```

### Get Task Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "title": "Get Groceries",
    "note": "get meat , cheese , fruits and others ... ",
    "CreatedDateTime": "2022-04-08T08:00:00",   
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "isComplete":  false,
    "completeDateTime": "2022-04-08T11:00:00",
}
```


## Update Task

### Update Task Request

```js
PUT /Task/{{id}}
```

```json
{
    "title": "Get Groceries",
    "note": "get meat , cheese , fruits and others ... ",
    "CreatedDateTime": "2022-04-08T08:00:00",   
    "isComplete":  false,
    "completeDateTime": "2022-04-08T11:00:00",
}
```

### Update Task Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Task/{{id}}
```

## Delete Task

### Delete Task Request

```js
DELETE /Task/{{id}}
```

### Delete Task Response

```js
204 No Content
```
