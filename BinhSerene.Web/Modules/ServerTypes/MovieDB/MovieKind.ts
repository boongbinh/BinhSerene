import { Decorators } from "@serenity-is/corelib";

export enum MovieKind {
    Film = 1,
    MiniSeries = 3,
    TestSeries = 4
}
Decorators.registerEnumType(MovieKind, 'BinhSerene.MovieDB.MovieKind', 'MovieDB.MovieKind');