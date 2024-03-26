import { MovieColumns, MovieRow, MovieService } from '@/ServerTypes/MovieDB';
import { Decorators, EntityGrid, QuickSearchField } from '@serenity-is/corelib';
import { MovieDialog } from './MovieDialog';

@Decorators.registerClass('BinhSerene.MovieDB.MovieGrid')
export class MovieGrid extends EntityGrid<MovieRow, any> {
    protected getColumnsKey() { return MovieColumns.columnsKey; }
    protected getDialogType() { return MovieDialog; }
    protected getRowDefinition() { return MovieRow; }
    protected getService() { return MovieService.baseUrl; }

    protected getQuickSearchFields(): QuickSearchField[] {
        return [
            { name: "", title: "All" },
            { name: "Description", title: "Description" },
            { name: "Storyline", title: "Storyline" },
            { name: "Year", title: "Year" }
        ];
    }
}