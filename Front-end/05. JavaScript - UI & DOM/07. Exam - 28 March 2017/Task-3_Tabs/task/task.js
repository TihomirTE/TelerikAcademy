function solve() {
    var template = [
        '<div class="tabs-control">' +
        '   <ul class="list list-titles">' +
        '   {{#each titles}}' +
        '       <li class="list-item">' +
        '           <label for="{{this.link}}" class="title">{{this.text}}</label>' +
        '       </li>' +
        '   {{/each}}' +
        '   </ul>' +
        '   <ul class="list list-contents">' +
        '   {{#each contents}}' +
        '       <li class="list-item">' +
        '           <input class="tab-content-toggle" id="{{this.link}}" name="tab-toggles" {{#if checked}}checked="checked/"{{/if}} type="radio">' +
        '           <div class="content">' +
        '               {{{this.text}}}' +
        '           </div>' +
        '       </li>' +
        '   {{/each}}' +
        '   </ul>' +
        '</div>'
    ].join('\n');

    return template;
}

if (typeof module !== 'undefined') {
    module.exports = solve;
}