window.registerBlazorCounter = () => {
    customElements.define('blazor-counter', class extends HTMLElement {
        constructor() {
            super();
            this.attachShadow({ mode: 'open' });
        }

        connectedCallback() {
            // Roep Blazor aan om de component te renderen binnen deze webcomponent
            Blazor.rootComponents.add('CounterElement', this.shadowRoot);
        }
    });
};
