CREATE TABLE "TodoListItems"
(
    "Id" uuid NOT NULL,
    "TodoTask" text NOT NULL,
    "IsDone" bool NOT NULL,
    "ScheduleTime" timestamp NOT NULL
)