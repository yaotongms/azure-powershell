﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Sql.Auditing.Model
{
    public enum AuditActionGroups
    {
        AUDIT_CHANGE_GROUP,
        BATCH_STARTED_GROUP,
        BATCH_COMPLETED_GROUP,
        APPLICATION_ROLE_CHANGE_PASSWORD_GROUP,
        BACKUP_RESTORE_GROUP,
        DATABASE_LOGOUT_GROUP,
        DATABASE_OBJECT_CHANGE_GROUP,
        DATABASE_OBJECT_OWNERSHIP_CHANGE_GROUP,
        DATABASE_OBJECT_PERMISSION_CHANGE_GROUP,
        DATABASE_OPERATION_GROUP,
        DATABASE_PERMISSION_CHANGE_GROUP,
        DATABASE_PRINCIPAL_CHANGE_GROUP,
        DATABASE_PRINCIPAL_IMPERSONATION_GROUP,
        DATABASE_ROLE_MEMBER_CHANGE_GROUP,
        FAILED_DATABASE_AUTHENTICATION_GROUP,
        SCHEMA_OBJECT_ACCESS_GROUP,
        SCHEMA_OBJECT_CHANGE_GROUP,
        SCHEMA_OBJECT_OWNERSHIP_CHANGE_GROUP,
        SCHEMA_OBJECT_PERMISSION_CHANGE_GROUP,
        SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP,
        USER_CHANGE_PASSWORD_GROUP,
        DBCC_GROUP,
        DATABASE_OWNERSHIP_CHANGE_GROUP,
        DATABASE_CHANGE_GROUP,
        LEDGER_OPERATION_GROUP,
        BROKER_LOGIN_GROUP,
        DATABASE_MIRRORING_LOGIN_GROUP,
        DATABASE_OBJECT_ACCESS_GROUP,
        EXTGOV_OPERATION_GROUP,
        FAILED_LOGIN_GROUP,
        FULLTEXT_GROUP,
        LOGIN_CHANGE_PASSWORD_GROUP,
        LOGOUT_GROUP,
        SERVER_OBJECT_CHANGE_GROUP,
        SERVER_OBJECT_OWNERSHIP_CHANGE_GROUP,
        SERVER_OBJECT_PERMISSION_CHANGE_GROUP,
        SERVER_OPERATION_GROUP,
        SERVER_PERMISSION_CHANGE_GROUP,
        SERVER_PRINCIPAL_CHANGE_GROUP,
        SERVER_PRINCIPAL_IMPERSONATION_GROUP,
        SERVER_ROLE_MEMBER_CHANGE_GROUP,
        SERVER_STATE_CHANGE_GROUP,
        SUCCESSFUL_LOGIN_GROUP,
        TRACE_CHANGE_GROUP,
        TRANSACTION_GROUP,
        USER_DEFINED_AUDIT_GROUP,
        SENSITIVE_BATCH_COMPLETED_GROUP
    }

    public enum StorageKeyKind { None, Primary, Secondary };

    public class ServerAuditModel : ServerDevOpsAuditModel
    {
        public AuditActionGroups[] AuditActionGroup { get; set; }

        public string PredicateExpression { get; set; }

        public StorageKeyKind StorageKeyType { get; set; }

        public uint? RetentionInDays { get; set; }
    }
}
