"use strict";

window.addEventListener("dragover", function(e) {
  e.preventDefault();
}, false);

window.addEventListener("drop", function(e) {
  e.preventDefault();
}, false);

//window.addEventListener("contextmenu", window => {
//  window.preventDefault();
//});

let PlotlyApp = {
  listenToAutosizeEvent: (div_container) => {
    div_container.on("plotly_autosize", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyAutosize" });
    });
    return div_container;
  },
  listenToEventEvent: (div_container) => {
    div_container.on("plotly_event", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyEvent" });
    });
    return div_container;
  },
  listenToClickEvent: (div_container, data_handler) => {
    div_container.on("plotly_click", function(eventData) {
      window.chrome.webview.postMessage({
        "event": "PlotlyClick",
        "data": data_handler(eventData)
      });
    });
    return div_container;
  },
  listenToHoverEvent: (div_container, data_handler) => {
    div_container.on("plotly_hover", function(eventData) {
      window.chrome.webview.postMessage({
        "event": "PlotlyHover",
        "data": data_handler(eventData)
      });
    });
    return div_container;
  },
  listenToUnhoverEvent: (div_container, data_handler) => {
    div_container.on("plotly_unhover", function(eventData) {
      window.chrome.webview.postMessage({
        "event": "PlotlyUnhover",
        "data": data_handler(eventData)
      });
    });
    return div_container;
  },
  listenToSelectingEvent: (div_container, data_handler) => {
    div_container.on("plotly_selecting", function(eventData) {
      window.chrome.webview.postMessage({
        "event": "PlotlySelecting",
        "data": data_handler(eventData)
      });
    });
    return div_container;
  },
  listenToSelectedEvent: (div_container, data_handler) => {
    div_container.on("plotly_selected", function(eventData) {

      const data = data_handler(eventData);

      window.chrome.webview.postMessage({
        "event": "PlotlySelected",
        "selected": data
      });
    });
    return div_container;
  },
  listenToDeselectEvent: (div_container) => {
    div_container.on("plotly_deselect", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyDeselect" });
    });
    return div_container;
  },
  listenToAnimatedEvent: (div_container) => {
    div_container.on("plotly_animated", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyAnimated" });
    });
    return div_container;
  },
  listenToRedrawEvent: (div_container) => {
    div_container.on("plotly_redraw", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyRedraw" });
    });
    return div_container;
  },
  listenToRestyleEvent: (div_container) => {
    div_container.on("plotly_restyle", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyRestyle" });
    });
    return div_container;
  },
  listenToRelayoutEvent: (div_container) => {
    div_container.on("plotly_relayout", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyRelayout" });
    });
    return div_container;
  },
  listenToRelayoutingEvent: (div_container) => {
    div_container.on("plotly_relayouting", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyRelayouting" });
    });
    return div_container;
  },
  listenToClickAnnotationEvent: (div_container) => {
    div_container.on("plotly_clickannotation", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyClickAnnotation" });
    });
    return div_container;
  },
  listenToLegendClickEvent: (div_container) => {
    div_container.on("plotly_legendclick", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyLegendClick" });
    });
    return div_container;
  },
  listenToLegendDoubleClickEvent: (div_container) => {
    div_container.on("plotly_legenddoubleclick", function() {
      window.chrome.webview.postMessage(
        { "event": "PlotlyLegendDoubleClick" });
    });
    return div_container;
  },
  listenToAfterPlotEvent: (div_container) => {
    div_container.on("plotly_afterplot", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyAfterPlot" });
    });
    return div_container;
  },
  listenToBeforePlotEvent: (div_container) => {
    div_container.on("plotly_beforeplot", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyBeforePlot" });
    });
    return div_container;
  },
  listenToBeforeHoverEvent: (div_container) => {
    div_container.on("plotly_beforeover", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyBeforeHover" });
    });
    return div_container;
  },
  listenToDoubleClickEvent: (div_container) => {
    div_container.on("plotly_doubleclick", function() {
      window.chrome.webview.postMessage({ "event": "PlotlyDoubleClick" });
    });
    return div_container;
  },
  listenToWebglContextLostEvent: (div_container) => {
    div_container.on("plotly_webglcontextlost", function() {
      window.chrome.webview.postMessage({
        "event": "PlotlyWebglContextLost"
      });
    });
    return div_container;
  },
  emitEvent: (eventName, data) => {
    window.chrome.webview.postMessage({ "event": eventName, "data": data });
  },
  emitDOMContentLoadedEvent: () => {
    window.chrome.webview.postMessage({ "event": "DOMContentLoaded" });
  },
  getDefaultConfiguration() {

    const config = {
      showLink: true,
      linkText: "https://trmcnealy.github.io",
      mapboxAccessToken: null,
      plotGlPixelRatio: 2,
      displayModeBar: "hover",
      frameMargins: 0,
      displaylogo: false,
      fillFrame: true,
      responsive: true,
      scrollZoom: true,
      modeBarButtons: false,
      modeBarButtonsToAdd: [],
      modeBarButtonsToRemove: [
        "hoverClosestCartesian",
        "hoverCompareCartesian"
      ],
      toImageButtonOptions: {
        format: "svg",
        filename: "custom_image",
        height: window.plotly_container.height,
        width: window.plotly_container.width,
        scale: 1
      }
    };

    return config;
  },
  getManagedObject: (name) => {
    return eval(`window.chrome.webview.hostObjects.sync.${name}`);
  },
  getSourceArray: (plotly_plot, source) => {
    const data_type = plotly_plot.GetDataSourceType(source);

    if (data_type === "float") {
      return new Float32Array(plotly_plot[source]);
    } else if (data_type === "double") {
      return new Float64Array(plotly_plot[source]);
    } else if (data_type === "int") {
      return new Int32Array(plotly_plot[source]);
    } else if (data_type === "long") {
      return new BigInt64Array(plotly_plot[source]);
    } else if (data_type === "string") {
      return plotly_plot[source];
    }
    return null;
  },
  getSourceArrayMapTimesValue: (plotly_plot, source, value) => {
    const data_type = plotly_plot.GetDataSourceType(source);

    if (data_type === "float") {
      return new Float32Array(plotly_plot[source]).map((element, index) => element * value);
    } else if (data_type === "double") {
      return new Float64Array(plotly_plot[source]).map((element, index) => element * value);
    } else if (data_type === "int") {
      return new Int32Array(plotly_plot[source]).map((element, index) => element * value);
    } else if (data_type === "long") {
      return new BigInt64Array(plotly_plot[source]).map((element, index) => element * value);
    } else if (data_type === "string") {
    }
    return null;
  }
};

function IsNull(val) {
  if (typeof val === typeof undefined) {
    return true;
  }

  if (val === undefined) {
    return true;
  }

  if (val === null) {
    return true;
  }
  
  return false;
}

function IsNotNull(val) {
  if (typeof val === typeof undefined) {
    return false;
  }

  if (val === undefined) {
    return false;
  }

  if (val === null) {
    return false;
  }
  
  return true;
}

function PlotlySelectedHandler(eventData) {
  if (eventData !== undefined &&
    eventData !== null &&
    eventData.points !== undefined &&
    eventData.points !== null) {
    var selectedData = new Array(eventData.points.length);
    let i = 0;
    eventData.points.forEach(function(pt) {
      selectedData[i] = {
        "curveNumber": pt.curveNumber,
        "pointIndex": pt.pointIndex,
        "pointNumber": pt.pointNumber,
        "x": pt.x,
        "y": pt.y
      };
      ++i;
    });
    return selectedData;
  }
  return null;
}

window.PlotlyApp = PlotlyApp;
