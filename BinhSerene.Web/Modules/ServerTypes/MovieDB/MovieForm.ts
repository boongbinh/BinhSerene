﻿import { StringEditor, IntegerEditor, DateEditor, EnumEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { MovieKind } from "./MovieKind";

export interface MovieForm {
    Title: StringEditor;
    Description: StringEditor;
    Storyline: StringEditor;
    Year: IntegerEditor;
    ReleaseDate: DateEditor;
    Runtime: IntegerEditor;
    Kind: EnumEditor;
    GenreList: LookupEditor;
}

export class MovieForm extends PrefixedContext {
    static readonly formKey = 'MovieDB.Movie';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MovieForm.init)  {
            MovieForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;
            var w3 = EnumEditor;
            var w4 = LookupEditor;

            initFormType(MovieForm, [
                'Title', w0,
                'Description', w0,
                'Storyline', w0,
                'Year', w1,
                'ReleaseDate', w2,
                'Runtime', w1,
                'Kind', w3,
                'GenreList', w4
            ]);
        }
    }
}

[MovieKind]; // referenced types