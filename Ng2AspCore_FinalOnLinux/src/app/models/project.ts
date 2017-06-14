import { IRoleAssignment } from "./role-assignment";

export interface IProject {
    projectId: number;
    title: string;
    description: string;
    roleAssignments: Array<IRoleAssignment>;
}