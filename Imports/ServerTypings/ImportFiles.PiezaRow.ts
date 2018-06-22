namespace Miapp2.ImportFiles {
    export interface PiezaRow {
        PzaId?: number;
        Pieza?: string;
        GrosTab?: number;
        Enchapado?: string;
        MtsEnchapado?: number;
        MtsCorte?: number;
    }

    export namespace PiezaRow {
        export const idProperty = 'PzaId';
        export const nameProperty = 'Pieza';
        export const localTextPrefix = 'ImportFiles.Pieza';

        export declare const enum Fields {
            PzaId = "PzaId",
            Pieza = "Pieza",
            GrosTab = "GrosTab",
            Enchapado = "Enchapado",
            MtsEnchapado = "MtsEnchapado",
            MtsCorte = "MtsCorte"
        }
    }
}
